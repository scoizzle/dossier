# Fact b035359b

Store id: 4fc3264b-3e0d-4339-8b3c-a6b2f06c3d39

## Text

```text
def get_joining_fields(self, reverse_join=False)
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
- posted_at: `2026-11-09T23:44:51.5420960+00:00`

## Data

```json
{
  "end_line": 857,
  "entity_kind": "method",
  "parent": "ForeignObject",
  "start_line": 854,
  "symbol": "ForeignObject.get_joining_fields"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":854,"selector":"L854-L857","symbol":"ForeignObject.get_joining_fields"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignObject.get_joining_fields](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 857,
    "entity_kind": "method",
    "parent": "ForeignObject",
    "start_line": 854,
    "symbol": "ForeignObject.get_joining_fields"
  },
  "id": "4fc3264b-3e0d-4339-8b3c-a6b2f06c3d39",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.5420960+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 854,
        "selector": "L854-L857",
        "symbol": "ForeignObject.get_joining_fields"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "edfcd01a-4439-4652-b710-854d18627268",
  "subject_name": "django/db/models/fields/related::ForeignObject.get_joining_fields",
  "tags": [
    "entity:method"
  ],
  "text": "def get_joining_fields(self, reverse_join=False)"
}
```
