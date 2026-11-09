# Fact 39906111

Store id: c9e53918-e828-4063-bc4b-fbb3e0e0264d

## Text

```text
def __repr__(self)
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
- posted_at: `2026-11-09T23:31:55.8733670+00:00`

## Data

```json
{
  "end_line": 1278,
  "entity_kind": "method",
  "parent": "RawSQL",
  "start_line": 1277,
  "symbol": "RawSQL.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1277,"selector":"L1277-L1278","symbol":"RawSQL.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::RawSQL.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1278,
    "entity_kind": "method",
    "parent": "RawSQL",
    "start_line": 1277,
    "symbol": "RawSQL.__repr__"
  },
  "id": "c9e53918-e828-4063-bc4b-fbb3e0e0264d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8733670+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1277,
        "selector": "L1277-L1278",
        "symbol": "RawSQL.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "effa8310-d9f5-4ea4-a8ef-f87f44463b17",
  "subject_name": "django/db/models/expressions::RawSQL.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
