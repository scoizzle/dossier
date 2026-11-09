# Fact 6c46c71e

Store id: f71a1250-b643-41b0-b5bd-1378a8049cee

## Text

```text
def __str__(self)
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
- posted_at: `2026-11-09T22:39:40.3191580+00:00`

## Data

```json
{
  "end_line": 66,
  "entity_kind": "method",
  "parent": "Deferred",
  "start_line": 65,
  "symbol": "Deferred.__str__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":65,"selector":"L65-L66","symbol":"Deferred.__str__"}`

## Referenced by

None.

## Subject

[django/db/models/base::Deferred.__str__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 66,
    "entity_kind": "method",
    "parent": "Deferred",
    "start_line": 65,
    "symbol": "Deferred.__str__"
  },
  "id": "f71a1250-b643-41b0-b5bd-1378a8049cee",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3191580+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 65,
        "selector": "L65-L66",
        "symbol": "Deferred.__str__"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "a47590bf-aae0-43f2-96c3-b383008777ba",
  "subject_name": "django/db/models/base::Deferred.__str__",
  "tags": [
    "entity:method"
  ],
  "text": "def __str__(self)"
}
```
