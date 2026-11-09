# Fact b10e78c8

Store id: a36be5b8-dc05-4b4d-b603-31389ccf2b7c

## Text

```text
class Lookup(Expression)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:03.1074730+00:00`

## Data

```json
{
  "end_line": 208,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 29,
  "symbol": "Lookup"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":29,"selector":"L29-L208","symbol":"Lookup"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::Lookup](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 208,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 29,
    "symbol": "Lookup"
  },
  "id": "a36be5b8-dc05-4b4d-b603-31389ccf2b7c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.1074730+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 29,
        "selector": "L29-L208",
        "symbol": "Lookup"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "f174502e-3c25-4e5c-a8b5-0f8a64231bc8",
  "subject_name": "django/db/models/lookups::Lookup",
  "tags": [
    "entity:class"
  ],
  "text": "class Lookup(Expression)"
}
```
