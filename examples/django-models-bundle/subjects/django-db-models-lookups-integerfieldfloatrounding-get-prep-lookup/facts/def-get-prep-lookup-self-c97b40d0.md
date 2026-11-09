# Fact c97b40d0

Store id: caad5886-bfd0-443d-a2b6-141a9b3b4446

## Text

```text
def get_prep_lookup(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:03.2951340+00:00`

## Data

```json
{
  "end_line": 472,
  "entity_kind": "method",
  "parent": "IntegerFieldFloatRounding",
  "start_line": 469,
  "symbol": "IntegerFieldFloatRounding.get_prep_lookup"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":469,"selector":"L469-L472","symbol":"IntegerFieldFloatRounding.get_prep_lookup"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::IntegerFieldFloatRounding.get_prep_lookup](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 472,
    "entity_kind": "method",
    "parent": "IntegerFieldFloatRounding",
    "start_line": 469,
    "symbol": "IntegerFieldFloatRounding.get_prep_lookup"
  },
  "id": "caad5886-bfd0-443d-a2b6-141a9b3b4446",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.2951340+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 469,
        "selector": "L469-L472",
        "symbol": "IntegerFieldFloatRounding.get_prep_lookup"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "aa5c73cc-4149-4229-9e56-9dddfa0aab31",
  "subject_name": "django/db/models/lookups::IntegerFieldFloatRounding.get_prep_lookup",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_lookup(self)"
}
```
