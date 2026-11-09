# Fact 728016c4

Store id: 1a0468d6-9fc7-4fc4-b009-ee860d64efef

## Text

```text
def __getstate__(self)
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
- posted_at: `2026-11-09T22:39:49.8441590+00:00`

## Data

```json
{
  "end_line": 2602,
  "entity_kind": "method",
  "parent": "Prefetch",
  "start_line": 2594,
  "symbol": "Prefetch.__getstate__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2594,"selector":"L2594-L2602","symbol":"Prefetch.__getstate__"}`

## Referenced by

None.

## Subject

[django/db/models/query::Prefetch.__getstate__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2602,
    "entity_kind": "method",
    "parent": "Prefetch",
    "start_line": 2594,
    "symbol": "Prefetch.__getstate__"
  },
  "id": "1a0468d6-9fc7-4fc4-b009-ee860d64efef",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.8441590+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2594,
        "selector": "L2594-L2602",
        "symbol": "Prefetch.__getstate__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "c10b46d4-a16e-41dc-9bc7-e72c6d8af600",
  "subject_name": "django/db/models/query::Prefetch.__getstate__",
  "tags": [
    "entity:method"
  ],
  "text": "def __getstate__(self)"
}
```
