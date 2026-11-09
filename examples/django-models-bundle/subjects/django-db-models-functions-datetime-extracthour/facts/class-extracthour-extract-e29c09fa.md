# Fact e29c09fa

Store id: dd62c229-0893-4974-8353-9a1bd5400dd8

## Text

```text
class ExtractHour(Extract)
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
- posted_at: `2026-11-09T23:32:01.2186570+00:00`

## Data

```json
{
  "end_line": 172,
  "entity_kind": "class",
  "parent": "datetime",
  "start_line": 171,
  "symbol": "ExtractHour"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":171,"selector":"L171-L172","symbol":"ExtractHour"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::ExtractHour](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 172,
    "entity_kind": "class",
    "parent": "datetime",
    "start_line": 171,
    "symbol": "ExtractHour"
  },
  "id": "dd62c229-0893-4974-8353-9a1bd5400dd8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.2186570+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 171,
        "selector": "L171-L172",
        "symbol": "ExtractHour"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "6e5af903-f9ee-4439-a6a1-fa6fa1b16ee9",
  "subject_name": "django/db/models/functions/datetime::ExtractHour",
  "tags": [
    "entity:class"
  ],
  "text": "class ExtractHour(Extract)"
}
```
