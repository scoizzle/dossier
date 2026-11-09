# Fact 3196c046

Store id: bc76db41-db5d-44a3-a669-0ae9679751da

## Text

```text
def datetimes(self, field_name, kind, order="ASC", tzinfo=None)
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
- posted_at: `2026-11-09T22:39:49.5898280+00:00`

## Data

```json
{
  "end_line": 1676,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1645,
  "symbol": "QuerySet.datetimes"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1645,"selector":"L1645-L1676","symbol":"QuerySet.datetimes"}`

## Items

```json
[
  {
    "text": "Return a list of datetime objects representing all available datetimes for the given field_name, scoped to 'kind'.",
    "locator": {
      "line": 1646
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.datetimes](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1676,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1645,
    "symbol": "QuerySet.datetimes"
  },
  "id": "bc76db41-db5d-44a3-a669-0ae9679751da",
  "items": [
    {
      "locator": {
        "line": 1646
      },
      "text": "Return a list of datetime objects representing all available datetimes for the given field_name, scoped to 'kind'."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.5898280+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1645,
        "selector": "L1645-L1676",
        "symbol": "QuerySet.datetimes"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "c7679012-4a5e-4f94-816e-f02e1842bb91",
  "subject_name": "django/db/models/query::QuerySet.datetimes",
  "tags": [
    "entity:method"
  ],
  "text": "def datetimes(self, field_name, kind, order=\"ASC\", tzinfo=None)"
}
```
