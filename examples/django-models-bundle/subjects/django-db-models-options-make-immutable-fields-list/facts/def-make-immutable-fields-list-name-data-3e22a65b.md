# Fact 3e22a65b

Store id: 8eafbff6-2d94-4d65-b28e-2f0cbd592db1

## Text

```text
def make_immutable_fields_list(name, data)
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
- posted_at: `2026-11-09T23:32:03.8834910+00:00`

## Data

```json
{
  "end_line": 87,
  "entity_kind": "function",
  "parent": "options",
  "start_line": 86,
  "symbol": "make_immutable_fields_list"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":86,"selector":"L86-L87","symbol":"make_immutable_fields_list"}`

## Referenced by

None.

## Subject

[django/db/models/options::make_immutable_fields_list](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 87,
    "entity_kind": "function",
    "parent": "options",
    "start_line": 86,
    "symbol": "make_immutable_fields_list"
  },
  "id": "8eafbff6-2d94-4d65-b28e-2f0cbd592db1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.8834910+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 86,
        "selector": "L86-L87",
        "symbol": "make_immutable_fields_list"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "10d042b8-1566-4498-91d8-0b2cfb997bd7",
  "subject_name": "django/db/models/options::make_immutable_fields_list",
  "tags": [
    "entity:function"
  ],
  "text": "def make_immutable_fields_list(name, data)"
}
```
