# Fact cf1e6555

Store id: 1ccbcecd-fbcc-46d2-9d7e-4ecfd408c39f

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
- posted_at: `2026-11-09T22:39:47.9718990+00:00`

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
  "id": "1ccbcecd-fbcc-46d2-9d7e-4ecfd408c39f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.9718990+00:00"
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
  "subject_id": "c19fa01f-48cd-4c48-82b3-fd889db71d05",
  "subject_name": "django/db/models/lookups::Lookup.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, lhs, rhs)"
}
```
