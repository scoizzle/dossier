# Fact c646d8b7

Store id: 7b0652d9-7004-426d-9158-26657a2f6bdb

## Text

```text
def get_prep_value(self, value)
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
- posted_at: `2026-11-09T23:31:58.7730150+00:00`

## Data

```json
{
  "end_line": 1289,
  "entity_kind": "method",
  "parent": "ForeignKey",
  "start_line": 1288,
  "symbol": "ForeignKey.get_prep_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1288,"selector":"L1288-L1289","symbol":"ForeignKey.get_prep_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignKey.get_prep_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1289,
    "entity_kind": "method",
    "parent": "ForeignKey",
    "start_line": 1288,
    "symbol": "ForeignKey.get_prep_value"
  },
  "id": "7b0652d9-7004-426d-9158-26657a2f6bdb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.7730150+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1288,
        "selector": "L1288-L1289",
        "symbol": "ForeignKey.get_prep_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "5f2d1b61-afde-49cc-9d38-dfcd35f39bbd",
  "subject_name": "django/db/models/fields/related::ForeignKey.get_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_value(self, value)"
}
```
