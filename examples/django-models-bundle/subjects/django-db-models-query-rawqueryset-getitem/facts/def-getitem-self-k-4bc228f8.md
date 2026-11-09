# Fact 4bc228f8

Store id: 45420dac-487c-4061-a781-b5d738dc17ca

## Text

```text
def __getitem__(self, k)
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
- posted_at: `2026-11-09T23:32:04.7624450+00:00`

## Data

```json
{
  "end_line": 2520,
  "entity_kind": "method",
  "parent": "RawQuerySet",
  "start_line": 2519,
  "symbol": "RawQuerySet.__getitem__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2519,"selector":"L2519-L2520","symbol":"RawQuerySet.__getitem__"}`

## Referenced by

None.

## Subject

[django/db/models/query::RawQuerySet.__getitem__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2520,
    "entity_kind": "method",
    "parent": "RawQuerySet",
    "start_line": 2519,
    "symbol": "RawQuerySet.__getitem__"
  },
  "id": "45420dac-487c-4061-a781-b5d738dc17ca",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.7624450+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2519,
        "selector": "L2519-L2520",
        "symbol": "RawQuerySet.__getitem__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "cffa0e38-35d5-49f8-99bf-c1f609c4fea2",
  "subject_name": "django/db/models/query::RawQuerySet.__getitem__",
  "tags": [
    "entity:method"
  ],
  "text": "def __getitem__(self, k)"
}
```
