# Fact db9c4cbd

Store id: 1e33cf21-88b8-46e5-8a00-3b003483dfe0

## Text

```text
def description(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:50.0601170+00:00`

## Data

```json
{
  "end_line": 1258,
  "entity_kind": "method",
  "parent": "CharField",
  "start_line": 1253,
  "symbol": "CharField.description"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1253,"selector":"L1253-L1258","symbol":"CharField.description"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::CharField.description](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1258,
    "entity_kind": "method",
    "parent": "CharField",
    "start_line": 1253,
    "symbol": "CharField.description"
  },
  "id": "1e33cf21-88b8-46e5-8a00-3b003483dfe0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.0601170+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1253,
        "selector": "L1253-L1258",
        "symbol": "CharField.description"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "d6c8b0f2-6508-442b-9fcf-b8412f0a9293",
  "subject_name": "django/db/models/fields/__init__::CharField.description",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def description(self)"
}
```
