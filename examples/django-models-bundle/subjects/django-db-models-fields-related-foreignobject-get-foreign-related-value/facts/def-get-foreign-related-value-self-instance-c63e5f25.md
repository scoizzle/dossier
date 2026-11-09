# Fact c63e5f25

Store id: 55650a19-dba0-4403-84e5-22d954d7089f

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
- posted_at: `2026-11-09T22:39:44.3357680+00:00`

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
  "id": "55650a19-dba0-4403-84e5-22d954d7089f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.3357680+00:00"
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
  "subject_id": "be6361aa-09f6-451a-8d0b-29dd0f83921d",
  "subject_name": "django/db/models/fields/related::ForeignObject.get_foreign_related_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_foreign_related_value(self, instance)"
}
```
