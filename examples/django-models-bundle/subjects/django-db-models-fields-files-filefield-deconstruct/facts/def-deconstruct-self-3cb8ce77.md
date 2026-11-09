# Fact 3cb8ce77

Store id: e0dfc468-8261-4b48-831f-0a51d440498c

## Text

```text
def deconstruct(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:43.2369790+00:00`

## Data

```json
{
  "end_line": 315,
  "entity_kind": "method",
  "parent": "FileField",
  "start_line": 307,
  "symbol": "FileField.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":307,"selector":"L307-L315","symbol":"FileField.deconstruct"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::FileField.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 315,
    "entity_kind": "method",
    "parent": "FileField",
    "start_line": 307,
    "symbol": "FileField.deconstruct"
  },
  "id": "e0dfc468-8261-4b48-831f-0a51d440498c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.2369790+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 307,
        "selector": "L307-L315",
        "symbol": "FileField.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "7bc9dde6-47d3-42b3-912f-d6558351e5b3",
  "subject_name": "django/db/models/fields/files::FileField.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
