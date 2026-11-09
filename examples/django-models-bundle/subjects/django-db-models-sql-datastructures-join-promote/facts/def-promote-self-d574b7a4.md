# Fact d574b7a4

Store id: 42daa12f-329b-417f-ba17-6807839fd42c

## Text

```text
def promote(self)
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
- posted_at: `2026-11-09T23:32:06.4768870+00:00`

## Data

```json
{
  "end_line": 178,
  "entity_kind": "method",
  "parent": "Join",
  "start_line": 175,
  "symbol": "Join.promote"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/datastructures.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":175,"selector":"L175-L178","symbol":"Join.promote"}`

## Referenced by

None.

## Subject

[django/db/models/sql/datastructures::Join.promote](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 178,
    "entity_kind": "method",
    "parent": "Join",
    "start_line": 175,
    "symbol": "Join.promote"
  },
  "id": "42daa12f-329b-417f-ba17-6807839fd42c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.4768870+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 175,
        "selector": "L175-L178",
        "symbol": "Join.promote"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/datastructures.py"
    }
  ],
  "status": "live",
  "subject_id": "b6f6be94-3195-4f6c-8f02-93ad4fbfc61d",
  "subject_name": "django/db/models/sql/datastructures::Join.promote",
  "tags": [
    "entity:method"
  ],
  "text": "def promote(self)"
}
```
