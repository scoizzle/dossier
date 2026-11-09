# Fact 95cf49dd

Store id: ae0f7852-d7c1-4b38-96ea-af31d89b160f

## Text

```text
def demote(self)
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
- posted_at: `2026-11-09T23:44:58.2356180+00:00`

## Data

```json
{
  "end_line": 173,
  "entity_kind": "method",
  "parent": "Join",
  "start_line": 170,
  "symbol": "Join.demote"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/datastructures.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":170,"selector":"L170-L173","symbol":"Join.demote"}`

## Referenced by

None.

## Subject

[django/db/models/sql/datastructures::Join.demote](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 173,
    "entity_kind": "method",
    "parent": "Join",
    "start_line": 170,
    "symbol": "Join.demote"
  },
  "id": "ae0f7852-d7c1-4b38-96ea-af31d89b160f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.2356180+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 170,
        "selector": "L170-L173",
        "symbol": "Join.demote"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/datastructures.py"
    }
  ],
  "status": "live",
  "subject_id": "697f3542-5c3f-48c9-86c9-b1322416f2b0",
  "subject_name": "django/db/models/sql/datastructures::Join.demote",
  "tags": [
    "entity:method"
  ],
  "text": "def demote(self)"
}
```
