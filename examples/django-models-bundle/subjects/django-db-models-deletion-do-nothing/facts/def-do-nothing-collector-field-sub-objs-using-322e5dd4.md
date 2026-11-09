# Fact 322e5dd4

Store id: d55581f7-3073-445a-b69f-89992e8a8ada

## Text

```text
def DO_NOTHING(collector, field, sub_objs, using)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:55.0782310+00:00`

## Data

```json
{
  "end_line": 81,
  "entity_kind": "function",
  "parent": "deletion",
  "start_line": 80,
  "symbol": "DO_NOTHING"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/deletion.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":80,"selector":"L80-L81","symbol":"DO_NOTHING"}`

## Referenced by

None.

## Subject

[django/db/models/deletion::DO_NOTHING](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 81,
    "entity_kind": "function",
    "parent": "deletion",
    "start_line": 80,
    "symbol": "DO_NOTHING"
  },
  "id": "d55581f7-3073-445a-b69f-89992e8a8ada",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.0782310+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 80,
        "selector": "L80-L81",
        "symbol": "DO_NOTHING"
      },
      "rel": "derived_from",
      "target": "django/db/models/deletion.py"
    }
  ],
  "status": "live",
  "subject_id": "2408caa4-d8c1-4841-a6d4-10cbb7363456",
  "subject_name": "django/db/models/deletion::DO_NOTHING",
  "tags": [
    "entity:function"
  ],
  "text": "def DO_NOTHING(collector, field, sub_objs, using)"
}
```
