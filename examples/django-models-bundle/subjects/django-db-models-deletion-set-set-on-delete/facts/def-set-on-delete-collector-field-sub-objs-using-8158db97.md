# Fact 8158db97

Store id: 08f2d2e5-94aa-4a38-a11f-871b8be6cb65

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
- posted_at: `2026-11-09T23:31:55.0607520+00:00`

## Data

```json
{
  "end_line": 61,
  "entity_kind": "function",
  "parent": "SET",
  "start_line": 60,
  "symbol": "SET.set_on_delete"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/deletion.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":60,"selector":"L60-L61","symbol":"SET.set_on_delete"}`

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
    "end_line": 61,
    "entity_kind": "function",
    "parent": "SET",
    "start_line": 60,
    "symbol": "SET.set_on_delete"
  },
  "id": "08f2d2e5-94aa-4a38-a11f-871b8be6cb65",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.0607520+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 60,
        "selector": "L60-L61",
        "symbol": "SET.set_on_delete"
      },
      "rel": "derived_from",
      "target": "django/db/models/deletion.py"
    }
  ],
  "status": "live",
  "subject_id": "8d247ec6-00de-497c-80c7-a991b50ceaf5",
  "subject_name": "django/db/models/deletion::SET.set_on_delete",
  "tags": [
    "entity:function"
  ],
  "text": "def set_on_delete(collector, field, sub_objs, using)"
}
```
