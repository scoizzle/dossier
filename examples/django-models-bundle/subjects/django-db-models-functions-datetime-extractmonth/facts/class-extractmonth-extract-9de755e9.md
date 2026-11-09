# Fact 9de755e9

Store id: 4186a43f-9513-40a8-800c-f969fc5fe411

## Text

```text
class ExtractMonth(Extract)
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
- posted_at: `2026-11-09T23:32:01.1906820+00:00`

## Data

```json
{
  "end_line": 135,
  "entity_kind": "class",
  "parent": "datetime",
  "start_line": 134,
  "symbol": "ExtractMonth"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":134,"selector":"L134-L135","symbol":"ExtractMonth"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::ExtractMonth](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 135,
    "entity_kind": "class",
    "parent": "datetime",
    "start_line": 134,
    "symbol": "ExtractMonth"
  },
  "id": "4186a43f-9513-40a8-800c-f969fc5fe411",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.1906820+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 134,
        "selector": "L134-L135",
        "symbol": "ExtractMonth"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "01258883-7973-4911-8953-bf64ff5e7698",
  "subject_name": "django/db/models/functions/datetime::ExtractMonth",
  "tags": [
    "entity:class"
  ],
  "text": "class ExtractMonth(Extract)"
}
```
