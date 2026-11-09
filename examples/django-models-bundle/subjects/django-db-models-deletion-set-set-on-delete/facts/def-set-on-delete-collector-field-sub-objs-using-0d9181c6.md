# Fact 0d9181c6

Store id: c393c0d0-0df5-4cd7-9bc3-107511099d2a

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
- posted_at: `2026-11-09T23:44:48.9008250+00:00`

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
  "id": "c393c0d0-0df5-4cd7-9bc3-107511099d2a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.9008250+00:00"
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
  "subject_id": "f3d6cc93-ec8d-46a2-b8dc-558b5814332a",
  "subject_name": "django/db/models/deletion::SET.set_on_delete",
  "tags": [
    "entity:function"
  ],
  "text": "def set_on_delete(collector, field, sub_objs, using)"
}
```
