# Fact 41d5a7f3

Store id: 780aea89-a28a-47d4-ad11-a1e25b86eca0

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
- posted_at: `2026-11-09T23:32:03.9723470+00:00`

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
  "id": "780aea89-a28a-47d4-ad11-a1e25b86eca0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.9723470+00:00"
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
  "subject_id": "5272a6a3-f658-4949-9e2b-c349df7eaba6",
  "subject_name": "django/db/models/options::Options.fields.is_not_an_m2m_field",
  "tags": [
    "entity:function"
  ],
  "text": "def is_not_an_m2m_field(f)"
}
```
