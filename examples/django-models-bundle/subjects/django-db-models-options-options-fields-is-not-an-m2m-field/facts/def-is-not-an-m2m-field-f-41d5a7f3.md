# Fact 41d5a7f3

Store id: ddf727bd-15e5-40e1-b227-64c8dbe0673e

## Text

```text
def is_not_an_m2m_field(f)
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
- posted_at: `2026-11-09T22:39:48.8400730+00:00`

## Data

```json
{
  "end_line": 550,
  "entity_kind": "function",
  "parent": "Options.fields",
  "start_line": 549,
  "symbol": "Options.fields.is_not_an_m2m_field"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":549,"selector":"L549-L550","symbol":"Options.fields.is_not_an_m2m_field"}`

## Referenced by

None.

## Subject

[django/db/models/options::Options.fields.is_not_an_m2m_field](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 550,
    "entity_kind": "function",
    "parent": "Options.fields",
    "start_line": 549,
    "symbol": "Options.fields.is_not_an_m2m_field"
  },
  "id": "ddf727bd-15e5-40e1-b227-64c8dbe0673e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.8400730+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 549,
        "selector": "L549-L550",
        "symbol": "Options.fields.is_not_an_m2m_field"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "00c6b7ae-69c0-48a6-933a-921dbef3c2b7",
  "subject_name": "django/db/models/options::Options.fields.is_not_an_m2m_field",
  "tags": [
    "entity:function"
  ],
  "text": "def is_not_an_m2m_field(f)"
}
```
