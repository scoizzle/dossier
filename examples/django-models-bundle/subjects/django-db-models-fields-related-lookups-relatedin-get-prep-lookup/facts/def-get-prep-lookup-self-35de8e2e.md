# Fact 35de8e2e

Store id: 44503a2d-2dc0-465c-bce0-a296752487ff

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
- posted_at: `2026-11-09T23:31:59.9769330+00:00`

## Data

```json
{
  "end_line": 84,
  "entity_kind": "method",
  "parent": "RelatedIn",
  "start_line": 43,
  "symbol": "RelatedIn.get_prep_lookup"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":43,"selector":"L43-L84","symbol":"RelatedIn.get_prep_lookup"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_lookups::RelatedIn.get_prep_lookup](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 84,
    "entity_kind": "method",
    "parent": "RelatedIn",
    "start_line": 43,
    "symbol": "RelatedIn.get_prep_lookup"
  },
  "id": "44503a2d-2dc0-465c-bce0-a296752487ff",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.9769330+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 43,
        "selector": "L43-L84",
        "symbol": "RelatedIn.get_prep_lookup"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "f5a8eedb-006f-4440-ab84-dab7932e8d76",
  "subject_name": "django/db/models/fields/related_lookups::RelatedIn.get_prep_lookup",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_lookup(self)"
}
```
