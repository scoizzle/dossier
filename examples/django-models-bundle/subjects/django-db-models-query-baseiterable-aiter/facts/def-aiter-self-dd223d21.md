# Fact dd223d21

Store id: 523b3cb0-1272-4787-b7c8-9c86b6b2a29d

## Text

```text
def __aiter__(self)
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
- posted_at: `2026-11-09T22:39:49.1880420+00:00`

## Data

```json
{
  "end_line": 118,
  "entity_kind": "method",
  "parent": "BaseIterable",
  "start_line": 117,
  "symbol": "BaseIterable.__aiter__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":117,"selector":"L117-L118","symbol":"BaseIterable.__aiter__"}`

## Referenced by

None.

## Subject

[django/db/models/query::BaseIterable.__aiter__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 118,
    "entity_kind": "method",
    "parent": "BaseIterable",
    "start_line": 117,
    "symbol": "BaseIterable.__aiter__"
  },
  "id": "523b3cb0-1272-4787-b7c8-9c86b6b2a29d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.1880420+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 117,
        "selector": "L117-L118",
        "symbol": "BaseIterable.__aiter__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "1d3656c6-67a7-4e74-a122-24779f9f7847",
  "subject_name": "django/db/models/query::BaseIterable.__aiter__",
  "tags": [
    "entity:method"
  ],
  "text": "def __aiter__(self)"
}
```
