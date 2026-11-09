# Fact 74477576

Store id: 2c246122-f534-4eef-9da9-ab8eb7dee1ba

## Text

```text
def __init__(self, queryset, **kwargs)
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
- posted_at: `2026-11-09T23:31:55.9786510+00:00`

## Data

```json
{
  "end_line": 1894,
  "entity_kind": "method",
  "parent": "Exists",
  "start_line": 1892,
  "symbol": "Exists.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1892,"selector":"L1892-L1894","symbol":"Exists.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Exists.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1894,
    "entity_kind": "method",
    "parent": "Exists",
    "start_line": 1892,
    "symbol": "Exists.__init__"
  },
  "id": "2c246122-f534-4eef-9da9-ab8eb7dee1ba",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9786510+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1892,
        "selector": "L1892-L1894",
        "symbol": "Exists.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "e53a1e2f-8caf-4755-b386-e925a57f99db",
  "subject_name": "django/db/models/expressions::Exists.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, queryset, **kwargs)"
}
```
