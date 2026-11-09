# Fact e6123c41

Store id: ede2fc37-3592-4a5d-a5b3-1e4de4894cef

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
- posted_at: `2026-11-09T22:39:49.7963690+00:00`

## Data

```json
{
  "end_line": 2497,
  "entity_kind": "method",
  "parent": "RawQuerySet",
  "start_line": 2495,
  "symbol": "RawQuerySet.__bool__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2495,"selector":"L2495-L2497","symbol":"RawQuerySet.__bool__"}`

## Referenced by

None.

## Subject

[django/db/models/query::RawQuerySet.__bool__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2497,
    "entity_kind": "method",
    "parent": "RawQuerySet",
    "start_line": 2495,
    "symbol": "RawQuerySet.__bool__"
  },
  "id": "ede2fc37-3592-4a5d-a5b3-1e4de4894cef",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.7963690+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2495,
        "selector": "L2495-L2497",
        "symbol": "RawQuerySet.__bool__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "fd2885a1-7030-4cff-9252-daee0645ccb3",
  "subject_name": "django/db/models/query::RawQuerySet.__bool__",
  "tags": [
    "entity:method"
  ],
  "text": "def __bool__(self)"
}
```
