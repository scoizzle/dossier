# Fact b732ff2b

Store id: 98a9a030-f534-47c9-a203-2ca01c2d7907

## Text

```text
def get_db_prep_save(self, value, connection)
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
- posted_at: `2026-11-09T22:39:44.3994640+00:00`

## Data

```json
{
  "end_line": 1283,
  "entity_kind": "method",
  "parent": "ForeignKey",
  "start_line": 1273,
  "symbol": "ForeignKey.get_db_prep_save"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1273,"selector":"L1273-L1283","symbol":"ForeignKey.get_db_prep_save"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignKey.get_db_prep_save](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1283,
    "entity_kind": "method",
    "parent": "ForeignKey",
    "start_line": 1273,
    "symbol": "ForeignKey.get_db_prep_save"
  },
  "id": "98a9a030-f534-47c9-a203-2ca01c2d7907",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.3994640+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1273,
        "selector": "L1273-L1283",
        "symbol": "ForeignKey.get_db_prep_save"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "6cd0274a-a1a7-46d1-b47e-d094075d2ee9",
  "subject_name": "django/db/models/fields/related::ForeignKey.get_db_prep_save",
  "tags": [
    "entity:method"
  ],
  "text": "def get_db_prep_save(self, value, connection)"
}
```
