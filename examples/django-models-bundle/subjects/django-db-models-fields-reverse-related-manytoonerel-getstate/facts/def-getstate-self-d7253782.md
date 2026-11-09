# Fact d7253782

Store id: bf0a068a-2335-48a5-ba2a-a8e700b48cff

## Text

```text
def __getstate__(self)
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
- posted_at: `2026-11-09T23:32:00.3249930+00:00`

## Data

```json
{
  "end_line": 292,
  "entity_kind": "method",
  "parent": "ManyToOneRel",
  "start_line": 289,
  "symbol": "ManyToOneRel.__getstate__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":289,"selector":"L289-L292","symbol":"ManyToOneRel.__getstate__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ManyToOneRel.__getstate__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 292,
    "entity_kind": "method",
    "parent": "ManyToOneRel",
    "start_line": 289,
    "symbol": "ManyToOneRel.__getstate__"
  },
  "id": "bf0a068a-2335-48a5-ba2a-a8e700b48cff",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.3249930+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 289,
        "selector": "L289-L292",
        "symbol": "ManyToOneRel.__getstate__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "22cf6241-15a0-4c8b-b490-a4469d1ef225",
  "subject_name": "django/db/models/fields/reverse_related::ManyToOneRel.__getstate__",
  "tags": [
    "entity:method"
  ],
  "text": "def __getstate__(self)"
}
```
