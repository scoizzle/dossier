# Fact 9f43ca7d

Store id: dd021604-2e31-41bd-a816-6ed9626d22ff

## Text

```text
class ExtractIsoWeekDay(Extract)
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
- posted_at: `2026-11-09T22:39:46.1448180+00:00`

## Data

```json
{
  "end_line": 164,
  "entity_kind": "class",
  "parent": "datetime",
  "start_line": 161,
  "symbol": "ExtractIsoWeekDay"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":161,"selector":"L161-L164","symbol":"ExtractIsoWeekDay"}`

## Items

```json
[
  {
    "text": "Return Monday=1 through Sunday=7, based on ISO-8601.",
    "locator": {
      "line": 162
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::ExtractIsoWeekDay](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 164,
    "entity_kind": "class",
    "parent": "datetime",
    "start_line": 161,
    "symbol": "ExtractIsoWeekDay"
  },
  "id": "dd021604-2e31-41bd-a816-6ed9626d22ff",
  "items": [
    {
      "locator": {
        "line": 162
      },
      "text": "Return Monday=1 through Sunday=7, based on ISO-8601."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.1448180+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 161,
        "selector": "L161-L164",
        "symbol": "ExtractIsoWeekDay"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "fc7cb8dd-1bc0-4c74-85d5-60216f884e12",
  "subject_name": "django/db/models/functions/datetime::ExtractIsoWeekDay",
  "tags": [
    "entity:class"
  ],
  "text": "class ExtractIsoWeekDay(Extract)"
}
```
