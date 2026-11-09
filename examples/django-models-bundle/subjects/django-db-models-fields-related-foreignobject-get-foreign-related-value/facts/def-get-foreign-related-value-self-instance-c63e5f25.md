# Fact c63e5f25

Store id: 97709145-9719-4ed8-8dce-3debc8da4ed2

## Text

```text
def get_foreign_related_value(self, instance)
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
- posted_at: `2026-11-09T23:44:51.5368600+00:00`

## Data

```json
{
  "end_line": 828,
  "entity_kind": "method",
  "parent": "ForeignObject",
  "start_line": 827,
  "symbol": "ForeignObject.get_foreign_related_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":827,"selector":"L827-L828","symbol":"ForeignObject.get_foreign_related_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignObject.get_foreign_related_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 828,
    "entity_kind": "method",
    "parent": "ForeignObject",
    "start_line": 827,
    "symbol": "ForeignObject.get_foreign_related_value"
  },
  "id": "97709145-9719-4ed8-8dce-3debc8da4ed2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.5368600+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 827,
        "selector": "L827-L828",
        "symbol": "ForeignObject.get_foreign_related_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "0e97bf85-56d8-4b2a-87e0-90fcca954085",
  "subject_name": "django/db/models/fields/related::ForeignObject.get_foreign_related_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_foreign_related_value(self, instance)"
}
```
