# Fact 3e22a65b

Store id: 7e9f8644-737d-4cab-b44a-0f995adbe345

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
- posted_at: `2026-11-09T23:44:55.4518540+00:00`

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
  "id": "7e9f8644-737d-4cab-b44a-0f995adbe345",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.4518540+00:00"
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
  "subject_id": "0e14f6ff-d276-47db-897a-506ee37525bc",
  "subject_name": "django/db/models/options::make_immutable_fields_list",
  "tags": [
    "entity:function"
  ],
  "text": "def make_immutable_fields_list(name, data)"
}
```
