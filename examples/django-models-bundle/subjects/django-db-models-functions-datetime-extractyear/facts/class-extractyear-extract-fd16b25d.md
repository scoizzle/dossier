# Fact fd16b25d

Store id: a99f4ade-5ec8-4704-9a67-f93a7044a035

## Text

```text
class ExtractYear(Extract)
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
- posted_at: `2026-11-09T23:44:53.3280710+00:00`

## Data

```json
{
  "end_line": 125,
  "entity_kind": "class",
  "parent": "datetime",
  "start_line": 124,
  "symbol": "ExtractYear"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":124,"selector":"L124-L125","symbol":"ExtractYear"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::ExtractYear](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 125,
    "entity_kind": "class",
    "parent": "datetime",
    "start_line": 124,
    "symbol": "ExtractYear"
  },
  "id": "a99f4ade-5ec8-4704-9a67-f93a7044a035",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.3280710+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 124,
        "selector": "L124-L125",
        "symbol": "ExtractYear"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "81b33d35-a46d-4cae-907b-853768c5048f",
  "subject_name": "django/db/models/functions/datetime::ExtractYear",
  "tags": [
    "entity:class"
  ],
  "text": "class ExtractYear(Extract)"
}
```
