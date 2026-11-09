# Fact 9a9f1d5a

Store id: 91acf2e9-e56d-4cc1-a7fd-f4a7ddac5f8e

## Text

```text
class DateTimeCheckMixin
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
- posted_at: `2026-11-09T23:44:50.0776430+00:00`

## Data

```json
{
  "end_line": 1461,
  "entity_kind": "class",
  "parent": "__init__",
  "start_line": 1391,
  "symbol": "DateTimeCheckMixin"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1391,"selector":"L1391-L1461","symbol":"DateTimeCheckMixin"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DateTimeCheckMixin](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1461,
    "entity_kind": "class",
    "parent": "__init__",
    "start_line": 1391,
    "symbol": "DateTimeCheckMixin"
  },
  "id": "91acf2e9-e56d-4cc1-a7fd-f4a7ddac5f8e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.0776430+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1391,
        "selector": "L1391-L1461",
        "symbol": "DateTimeCheckMixin"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "38133423-a078-4114-b7ea-e8c2f48f655e",
  "subject_name": "django/db/models/fields/__init__::DateTimeCheckMixin",
  "tags": [
    "entity:class"
  ],
  "text": "class DateTimeCheckMixin"
}
```
