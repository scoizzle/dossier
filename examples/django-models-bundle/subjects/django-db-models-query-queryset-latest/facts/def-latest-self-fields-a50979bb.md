# Fact a50979bb

Store id: d67f9092-570d-4065-b814-78bbc5bb1c29

## Text

```text
def latest(self, *fields)
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
- posted_at: `2026-11-09T23:44:55.9454460+00:00`

## Data

```json
{
  "end_line": 1216,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1209,
  "symbol": "QuerySet.latest"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1209,"selector":"L1209-L1216","symbol":"QuerySet.latest"}`

## Items

```json
[
  {
    "text": "Return the latest object according to fields (if given) or by the model's Meta.get_latest_by.",
    "locator": {
      "line": 1210
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.latest](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1216,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1209,
    "symbol": "QuerySet.latest"
  },
  "id": "d67f9092-570d-4065-b814-78bbc5bb1c29",
  "items": [
    {
      "locator": {
        "line": 1210
      },
      "text": "Return the latest object according to fields (if given) or by the model's Meta.get_latest_by."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.9454460+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1209,
        "selector": "L1209-L1216",
        "symbol": "QuerySet.latest"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "83d0cc41-144f-4625-88fc-827be04e2c34",
  "subject_name": "django/db/models/query::QuerySet.latest",
  "tags": [
    "entity:method"
  ],
  "text": "def latest(self, *fields)"
}
```
