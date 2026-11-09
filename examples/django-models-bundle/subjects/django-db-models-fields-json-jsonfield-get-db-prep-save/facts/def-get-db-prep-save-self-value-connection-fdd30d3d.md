# Fact fdd30d3d

Store id: 4aa52603-45ec-49de-abfe-c6811cd02c81

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
- posted_at: `2026-11-09T23:44:50.9444650+00:00`

## Data

```json
{
  "end_line": 120,
  "entity_kind": "method",
  "parent": "JSONField",
  "start_line": 106,
  "symbol": "JSONField.get_db_prep_save"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":106,"selector":"L106-L120","symbol":"JSONField.get_db_prep_save"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::JSONField.get_db_prep_save](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 120,
    "entity_kind": "method",
    "parent": "JSONField",
    "start_line": 106,
    "symbol": "JSONField.get_db_prep_save"
  },
  "id": "4aa52603-45ec-49de-abfe-c6811cd02c81",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.9444650+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 106,
        "selector": "L106-L120",
        "symbol": "JSONField.get_db_prep_save"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "96a00954-10e5-4ac7-84db-2cba68cf8e1c",
  "subject_name": "django/db/models/fields/json::JSONField.get_db_prep_save",
  "tags": [
    "entity:method"
  ],
  "text": "def get_db_prep_save(self, value, connection)"
}
```
