# Fact 5092ff03

Store id: f1913e85-a133-493b-a248-360001d411d2

## Text

```text
class TruncDay(TruncBase)
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
- posted_at: `2026-11-09T23:44:53.4026900+00:00`

## Data

```json
{
  "end_line": 380,
  "entity_kind": "class",
  "parent": "datetime",
  "start_line": 379,
  "symbol": "TruncDay"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":379,"selector":"L379-L380","symbol":"TruncDay"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::TruncDay](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 380,
    "entity_kind": "class",
    "parent": "datetime",
    "start_line": 379,
    "symbol": "TruncDay"
  },
  "id": "f1913e85-a133-493b-a248-360001d411d2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.4026900+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 379,
        "selector": "L379-L380",
        "symbol": "TruncDay"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "31f9e52f-2032-4402-bd12-90857dbaaab4",
  "subject_name": "django/db/models/functions/datetime::TruncDay",
  "tags": [
    "entity:class"
  ],
  "text": "class TruncDay(TruncBase)"
}
```
