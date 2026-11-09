# Fact 67877b97

Store id: 43469f02-9a06-4e47-9638-51770f3ae5b6

## Text

```text
def asc(self, **kwargs)
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
- posted_at: `2026-11-09T23:31:55.8362380+00:00`

## Data

```json
{
  "end_line": 931,
  "entity_kind": "method",
  "parent": "F",
  "start_line": 930,
  "symbol": "F.asc"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":930,"selector":"L930-L931","symbol":"F.asc"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::F.asc](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 931,
    "entity_kind": "method",
    "parent": "F",
    "start_line": 930,
    "symbol": "F.asc"
  },
  "id": "43469f02-9a06-4e47-9638-51770f3ae5b6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8362380+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 930,
        "selector": "L930-L931",
        "symbol": "F.asc"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "1400c272-91a2-4b09-88bb-e4296b329182",
  "subject_name": "django/db/models/expressions::F.asc",
  "tags": [
    "entity:method"
  ],
  "text": "def asc(self, **kwargs)"
}
```
