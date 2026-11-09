# Fact f7a1619f

Store id: 63829ba8-8ad9-49c8-936a-f909d59ffbe1

## Text

```text
def __bool__(self)
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
- posted_at: `2026-11-09T23:44:55.8600890+00:00`

## Data

```json
{
  "end_line": 488,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 486,
  "symbol": "QuerySet.__bool__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":486,"selector":"L486-L488","symbol":"QuerySet.__bool__"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.__bool__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 488,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 486,
    "symbol": "QuerySet.__bool__"
  },
  "id": "63829ba8-8ad9-49c8-936a-f909d59ffbe1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.8600890+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 486,
        "selector": "L486-L488",
        "symbol": "QuerySet.__bool__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "7270a746-ea6b-4f26-83a0-679194acec6f",
  "subject_name": "django/db/models/query::QuerySet.__bool__",
  "tags": [
    "entity:method"
  ],
  "text": "def __bool__(self)"
}
```
