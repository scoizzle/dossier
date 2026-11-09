# Fact 6f1f6724

Store id: dd48c719-e361-45ff-bfbc-c415982b21fe

## Text

```text
def __init__(self, *expressions, **extra)
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
- posted_at: `2026-11-09T23:44:54.0770210+00:00`

## Data

```json
{
  "end_line": 139,
  "entity_kind": "method",
  "parent": "Concat",
  "start_line": 135,
  "symbol": "Concat.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":135,"selector":"L135-L139","symbol":"Concat.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::Concat.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 139,
    "entity_kind": "method",
    "parent": "Concat",
    "start_line": 135,
    "symbol": "Concat.__init__"
  },
  "id": "dd48c719-e361-45ff-bfbc-c415982b21fe",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.0770210+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 135,
        "selector": "L135-L139",
        "symbol": "Concat.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "df5ac17e-e7b3-4c0d-989c-924a86dd0e83",
  "subject_name": "django/db/models/functions/text::Concat.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, *expressions, **extra)"
}
```
