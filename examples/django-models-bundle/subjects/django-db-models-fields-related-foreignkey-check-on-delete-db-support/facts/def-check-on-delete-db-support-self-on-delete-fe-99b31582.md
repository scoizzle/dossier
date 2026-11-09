# Fact 99b31582

Store id: 6806abb6-6239-4996-94d3-2b9c9a753faa

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
- posted_at: `2026-11-09T22:39:44.3759650+00:00`

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
  "id": "6806abb6-6239-4996-94d3-2b9c9a753faa",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.3759650+00:00"
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
  "subject_id": "ba1d5174-5b20-4238-9a2a-632e2f816280",
  "subject_name": "django/db/models/fields/related::ForeignKey._check_on_delete_db_support",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_on_delete_db_support(self, on_delete, feature_flag, databases)"
}
```
