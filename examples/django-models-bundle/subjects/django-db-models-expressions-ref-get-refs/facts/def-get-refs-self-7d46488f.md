# Fact 7d46488f

Store id: 7f24bc52-4310-4723-94b1-cf5d2aa89124

## Text

```text
def get_refs(self)
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
- posted_at: `2026-11-09T23:44:49.5795380+00:00`

## Data

```json
{
  "end_line": 1474,
  "entity_kind": "method",
  "parent": "Ref",
  "start_line": 1473,
  "symbol": "Ref.get_refs"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1473,"selector":"L1473-L1474","symbol":"Ref.get_refs"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Ref.get_refs](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1474,
    "entity_kind": "method",
    "parent": "Ref",
    "start_line": 1473,
    "symbol": "Ref.get_refs"
  },
  "id": "7f24bc52-4310-4723-94b1-cf5d2aa89124",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5795380+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1473,
        "selector": "L1473-L1474",
        "symbol": "Ref.get_refs"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "e32dabb0-93e2-4e33-9b79-4d703c381cdb",
  "subject_name": "django/db/models/expressions::Ref.get_refs",
  "tags": [
    "entity:method"
  ],
  "text": "def get_refs(self)"
}
```
