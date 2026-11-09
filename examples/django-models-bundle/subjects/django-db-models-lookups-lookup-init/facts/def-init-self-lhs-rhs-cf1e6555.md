# Fact cf1e6555

Store id: f8073491-ce98-4d52-9854-2b716d0562d8

## Text

```text
def __init__(self, lhs, rhs)
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
- posted_at: `2026-11-09T23:32:03.1197790+00:00`

## Data

```json
{
  "end_line": 51,
  "entity_kind": "method",
  "parent": "Lookup",
  "start_line": 34,
  "symbol": "Lookup.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":34,"selector":"L34-L51","symbol":"Lookup.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::Lookup.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 51,
    "entity_kind": "method",
    "parent": "Lookup",
    "start_line": 34,
    "symbol": "Lookup.__init__"
  },
  "id": "f8073491-ce98-4d52-9854-2b716d0562d8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.1197790+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 34,
        "selector": "L34-L51",
        "symbol": "Lookup.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "5b019733-6d5a-4664-b2b6-2cd70afdaf69",
  "subject_name": "django/db/models/lookups::Lookup.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, lhs, rhs)"
}
```
