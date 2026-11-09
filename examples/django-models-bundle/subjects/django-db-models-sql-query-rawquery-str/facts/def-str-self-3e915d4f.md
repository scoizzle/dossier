# Fact 3e915d4f

Store id: c5f3adc3-2488-4d17-8a01-aeb3628a6760

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
- posted_at: `2026-11-09T22:39:51.2101240+00:00`

## Data

```json
{
  "end_line": 206,
  "entity_kind": "method",
  "parent": "RawQuery",
  "start_line": 203,
  "symbol": "RawQuery.__str__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":203,"selector":"L203-L206","symbol":"RawQuery.__str__"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::RawQuery.__str__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 206,
    "entity_kind": "method",
    "parent": "RawQuery",
    "start_line": 203,
    "symbol": "RawQuery.__str__"
  },
  "id": "c5f3adc3-2488-4d17-8a01-aeb3628a6760",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.2101240+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 203,
        "selector": "L203-L206",
        "symbol": "RawQuery.__str__"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "38c94299-85bd-4cdb-b083-99b2885ad6cf",
  "subject_name": "django/db/models/sql/query::RawQuery.__str__",
  "tags": [
    "entity:method"
  ],
  "text": "def __str__(self)"
}
```
