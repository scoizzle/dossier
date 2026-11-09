# Fact 9f43ca7d

Store id: 37dfb83b-ac81-4624-b217-d1a03d510aeb

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
- posted_at: `2026-11-09T23:44:53.3536220+00:00`

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
  "id": "37dfb83b-ac81-4624-b217-d1a03d510aeb",
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
    "posted_at": "2026-11-09T23:44:53.3536220+00:00"
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
  "subject_id": "b60b8fad-17d3-49ac-8466-94dc652696ad",
  "subject_name": "django/db/models/functions/datetime::ExtractIsoWeekDay",
  "tags": [
    "entity:class"
  ],
  "text": "class ExtractIsoWeekDay(Extract)"
}
```
