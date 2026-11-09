# Fact 728016c4

Store id: 34a265e7-23bb-4c35-beae-c8687fb84363

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
- posted_at: `2026-11-09T23:32:04.7904790+00:00`

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
  "id": "34a265e7-23bb-4c35-beae-c8687fb84363",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.7904790+00:00"
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
  "subject_id": "5fee1caa-0499-420a-ba52-99d41518de87",
  "subject_name": "django/db/models/query::Prefetch.__getstate__",
  "tags": [
    "entity:method"
  ],
  "text": "def __getstate__(self)"
}
```
