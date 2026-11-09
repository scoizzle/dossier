# Fact 99b31582

Store id: b23021e8-0c7c-46ea-8bae-d2656d79c9d9

## Text

```text
def _check_on_delete_db_support(self, on_delete, feature_flag, databases)
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
- posted_at: `2026-11-09T23:31:58.7467920+00:00`

## Data

```json
{
  "end_line": 1079,
  "entity_kind": "method",
  "parent": "ForeignKey",
  "start_line": 1064,
  "symbol": "ForeignKey._check_on_delete_db_support"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1064,"selector":"L1064-L1079","symbol":"ForeignKey._check_on_delete_db_support"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignKey._check_on_delete_db_support](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1079,
    "entity_kind": "method",
    "parent": "ForeignKey",
    "start_line": 1064,
    "symbol": "ForeignKey._check_on_delete_db_support"
  },
  "id": "b23021e8-0c7c-46ea-8bae-d2656d79c9d9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.7467920+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1064,
        "selector": "L1064-L1079",
        "symbol": "ForeignKey._check_on_delete_db_support"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "25a09a20-e4fb-4d21-98e3-002bb589739e",
  "subject_name": "django/db/models/fields/related::ForeignKey._check_on_delete_db_support",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_on_delete_db_support(self, on_delete, feature_flag, databases)"
}
```
