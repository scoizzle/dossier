# Fact b5a0cf20

Store id: f5729a84-0cab-4078-bced-7f761da39fe9

## Text

```text
def __hash__(self)
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
- posted_at: `2026-11-09T23:44:54.9020880+00:00`

## Data

```json
{
  "end_line": 182,
  "entity_kind": "method",
  "parent": "Lookup",
  "start_line": 181,
  "symbol": "Lookup.__hash__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":181,"selector":"L181-L182","symbol":"Lookup.__hash__"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::Lookup.__hash__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 182,
    "entity_kind": "method",
    "parent": "Lookup",
    "start_line": 181,
    "symbol": "Lookup.__hash__"
  },
  "id": "f5729a84-0cab-4078-bced-7f761da39fe9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.9020880+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 181,
        "selector": "L181-L182",
        "symbol": "Lookup.__hash__"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "a543ff2e-8552-4662-bc56-e3a311ee770b",
  "subject_name": "django/db/models/lookups::Lookup.__hash__",
  "tags": [
    "entity:method"
  ],
  "text": "def __hash__(self)"
}
```
