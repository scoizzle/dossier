# Fact a335d4f0

Store id: 6e46600a-faef-4579-84e1-dbc1aa9d48f1

## Text

```text
class TruncHour(TruncBase)
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
- posted_at: `2026-11-09T22:39:46.2142840+00:00`

## Data

```json
{
  "end_line": 408,
  "entity_kind": "class",
  "parent": "datetime",
  "start_line": 407,
  "symbol": "TruncHour"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":407,"selector":"L407-L408","symbol":"TruncHour"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::TruncHour](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 408,
    "entity_kind": "class",
    "parent": "datetime",
    "start_line": 407,
    "symbol": "TruncHour"
  },
  "id": "6e46600a-faef-4579-84e1-dbc1aa9d48f1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.2142840+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 407,
        "selector": "L407-L408",
        "symbol": "TruncHour"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "6a54847c-edd7-4ae1-8219-77405c98d9c7",
  "subject_name": "django/db/models/functions/datetime::TruncHour",
  "tags": [
    "entity:class"
  ],
  "text": "class TruncHour(TruncBase)"
}
```
