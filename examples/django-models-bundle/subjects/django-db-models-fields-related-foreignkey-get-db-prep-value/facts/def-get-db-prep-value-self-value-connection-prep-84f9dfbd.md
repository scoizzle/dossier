# Fact 84f9dfbd

Store id: f65aa3ca-3df5-478a-ab23-b1ccc5a5b0ac

## Text

```text
def get_db_prep_value(self, value, connection, prepared=False)
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
- posted_at: `2026-11-09T23:44:51.5928310+00:00`

## Data

```json
{
  "end_line": 1286,
  "entity_kind": "method",
  "parent": "ForeignKey",
  "start_line": 1285,
  "symbol": "ForeignKey.get_db_prep_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1285,"selector":"L1285-L1286","symbol":"ForeignKey.get_db_prep_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignKey.get_db_prep_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1286,
    "entity_kind": "method",
    "parent": "ForeignKey",
    "start_line": 1285,
    "symbol": "ForeignKey.get_db_prep_value"
  },
  "id": "f65aa3ca-3df5-478a-ab23-b1ccc5a5b0ac",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.5928310+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1285,
        "selector": "L1285-L1286",
        "symbol": "ForeignKey.get_db_prep_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "df41d724-e783-4a4c-b172-b33f743e5b33",
  "subject_name": "django/db/models/fields/related::ForeignKey.get_db_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_db_prep_value(self, value, connection, prepared=False)"
}
```
