# Fact 9f43ca7d

Store id: 46b93cc5-2f5f-4a60-b935-0652d5f054b1

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
- posted_at: `2026-11-09T23:32:01.2137310+00:00`

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
  "id": "46b93cc5-2f5f-4a60-b935-0652d5f054b1",
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
    "posted_at": "2026-11-09T23:32:01.2137310+00:00"
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
  "subject_id": "23639666-ab86-4250-84b2-8d08bdf2ea22",
  "subject_name": "django/db/models/functions/datetime::ExtractIsoWeekDay",
  "tags": [
    "entity:class"
  ],
  "text": "class ExtractIsoWeekDay(Extract)"
}
```
