# Fact f7a1619f

Store id: 54e3ca24-271d-43e6-9006-89442052bd8b

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
- posted_at: `2026-11-09T23:32:04.3413280+00:00`

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
  "id": "54e3ca24-271d-43e6-9006-89442052bd8b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.3413280+00:00"
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
  "subject_id": "00050fc1-1242-446d-aa2c-30fe19af1083",
  "subject_name": "django/db/models/query::QuerySet.__bool__",
  "tags": [
    "entity:method"
  ],
  "text": "def __bool__(self)"
}
```
