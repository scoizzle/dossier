# Fact f7a1619f

Store id: ba7c6229-39e6-4220-b4a9-5970bb194024

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
- posted_at: `2026-11-09T22:39:49.3357460+00:00`

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
  "id": "ba7c6229-39e6-4220-b4a9-5970bb194024",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.3357460+00:00"
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
  "subject_id": "6cd4b417-268c-4e79-aac0-3e0227acfeb8",
  "subject_name": "django/db/models/query::QuerySet.__bool__",
  "tags": [
    "entity:method"
  ],
  "text": "def __bool__(self)"
}
```
