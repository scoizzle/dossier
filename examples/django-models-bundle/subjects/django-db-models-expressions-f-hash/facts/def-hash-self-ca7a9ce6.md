# Fact ca7a9ce6

Store id: 7c35ddb1-f8c4-4baa-897c-665b809200da

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
- posted_at: `2026-11-09T23:44:49.4878500+00:00`

## Data

```json
{
  "end_line": 940,
  "entity_kind": "method",
  "parent": "F",
  "start_line": 939,
  "symbol": "F.__hash__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":939,"selector":"L939-L940","symbol":"F.__hash__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::F.__hash__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 940,
    "entity_kind": "method",
    "parent": "F",
    "start_line": 939,
    "symbol": "F.__hash__"
  },
  "id": "7c35ddb1-f8c4-4baa-897c-665b809200da",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.4878500+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 939,
        "selector": "L939-L940",
        "symbol": "F.__hash__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "ee0292f4-209c-4c4b-ab55-94505bf8acf8",
  "subject_name": "django/db/models/expressions::F.__hash__",
  "tags": [
    "entity:method"
  ],
  "text": "def __hash__(self)"
}
```
