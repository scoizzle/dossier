# Fact 39786aca

Store id: 264cb648-cecb-45eb-8217-23e84e01bc25

## Text

```text
def db_returning_fields(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:cached_property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:48.9857060+00:00`

## Data

```json
{
  "end_line": 1052,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 1040,
  "symbol": "Options.db_returning_fields"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1040,"selector":"L1040-L1052","symbol":"Options.db_returning_fields"}`

## Items

```json
[
  {
    "text": "Private API intended only to be used by Django itself. Fields to be returned after a database insert.",
    "locator": {
      "line": 1042
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/options::Options.db_returning_fields](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1052,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 1040,
    "symbol": "Options.db_returning_fields"
  },
  "id": "264cb648-cecb-45eb-8217-23e84e01bc25",
  "items": [
    {
      "locator": {
        "line": 1042
      },
      "text": "Private API intended only to be used by Django itself. Fields to be returned after a database insert."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.9857060+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1040,
        "selector": "L1040-L1052",
        "symbol": "Options.db_returning_fields"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "819e1dc7-d1d1-4755-bda6-d9337c586470",
  "subject_name": "django/db/models/options::Options.db_returning_fields",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def db_returning_fields(self)"
}
```
