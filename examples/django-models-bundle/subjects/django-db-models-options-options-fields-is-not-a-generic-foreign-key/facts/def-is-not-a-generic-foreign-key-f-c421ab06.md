# Fact c421ab06

Store id: 3445bafa-4d6a-4348-9d56-957cce15b273

## Text

```text
def is_not_a_generic_foreign_key(f)
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
- posted_at: `2026-11-09T23:44:55.5318110+00:00`

## Data

```json
{
  "end_line": 560,
  "entity_kind": "function",
  "parent": "Options.fields",
  "start_line": 555,
  "symbol": "Options.fields.is_not_a_generic_foreign_key"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":555,"selector":"L555-L560","symbol":"Options.fields.is_not_a_generic_foreign_key"}`

## Referenced by

None.

## Subject

[django/db/models/options::Options.fields.is_not_a_generic_foreign_key](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 560,
    "entity_kind": "function",
    "parent": "Options.fields",
    "start_line": 555,
    "symbol": "Options.fields.is_not_a_generic_foreign_key"
  },
  "id": "3445bafa-4d6a-4348-9d56-957cce15b273",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.5318110+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 555,
        "selector": "L555-L560",
        "symbol": "Options.fields.is_not_a_generic_foreign_key"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "c77b8c7a-63e3-40a6-8dff-03f0310a4bda",
  "subject_name": "django/db/models/options::Options.fields.is_not_a_generic_foreign_key",
  "tags": [
    "entity:function"
  ],
  "text": "def is_not_a_generic_foreign_key(f)"
}
```
