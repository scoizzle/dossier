# Fact 322e5dd4

Store id: f18bb77b-4034-496f-9115-aeaa9b8c2adc

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
- posted_at: `2026-11-09T23:44:48.9032380+00:00`

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
  "id": "f18bb77b-4034-496f-9115-aeaa9b8c2adc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.9032380+00:00"
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
  "subject_id": "b362266c-fd46-4081-a387-0dfca0088dd3",
  "subject_name": "django/db/models/deletion::DO_NOTHING",
  "tags": [
    "entity:function"
  ],
  "text": "def DO_NOTHING(collector, field, sub_objs, using)"
}
```
