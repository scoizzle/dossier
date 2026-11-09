# Fact 0d9181c6

Store id: 57434fb5-742d-441a-9370-08d16c6f246e

## Text

```text
def set_on_delete(collector, field, sub_objs, using)
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
- posted_at: `2026-11-09T22:39:41.0015190+00:00`

## Data

```json
{
  "end_line": 56,
  "entity_kind": "function",
  "parent": "SET",
  "start_line": 55,
  "symbol": "SET.set_on_delete"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/deletion.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":55,"selector":"L55-L56","symbol":"SET.set_on_delete"}`

## Referenced by

None.

## Subject

[django/db/models/deletion::SET.set_on_delete](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 56,
    "entity_kind": "function",
    "parent": "SET",
    "start_line": 55,
    "symbol": "SET.set_on_delete"
  },
  "id": "57434fb5-742d-441a-9370-08d16c6f246e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.0015190+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 55,
        "selector": "L55-L56",
        "symbol": "SET.set_on_delete"
      },
      "rel": "derived_from",
      "target": "django/db/models/deletion.py"
    }
  ],
  "status": "live",
  "subject_id": "60c7b417-7d87-4771-b8b2-c206972a65d0",
  "subject_name": "django/db/models/deletion::SET.set_on_delete",
  "tags": [
    "entity:function"
  ],
  "text": "def set_on_delete(collector, field, sub_objs, using)"
}
```
