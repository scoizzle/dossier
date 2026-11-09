# Fact 142151e1

Store id: e8f4903f-d089-4384-a6b1-10a663f0da98

## Text

```text
def SET_NULL(collector, field, sub_objs, using)
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
- posted_at: `2026-11-09T23:44:48.9020160+00:00`

## Data

```json
{
  "end_line": 70,
  "entity_kind": "function",
  "parent": "deletion",
  "start_line": 69,
  "symbol": "SET_NULL"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/deletion.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":69,"selector":"L69-L70","symbol":"SET_NULL"}`

## Referenced by

None.

## Subject

[django/db/models/deletion::SET_NULL](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 70,
    "entity_kind": "function",
    "parent": "deletion",
    "start_line": 69,
    "symbol": "SET_NULL"
  },
  "id": "e8f4903f-d089-4384-a6b1-10a663f0da98",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.9020160+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 69,
        "selector": "L69-L70",
        "symbol": "SET_NULL"
      },
      "rel": "derived_from",
      "target": "django/db/models/deletion.py"
    }
  ],
  "status": "live",
  "subject_id": "df6ab8b7-a190-40a3-8b19-e53b3db58249",
  "subject_name": "django/db/models/deletion::SET_NULL",
  "tags": [
    "entity:function"
  ],
  "text": "def SET_NULL(collector, field, sub_objs, using)"
}
```
