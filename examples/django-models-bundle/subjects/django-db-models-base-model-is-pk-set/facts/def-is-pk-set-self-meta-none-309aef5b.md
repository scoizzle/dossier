# Fact 309aef5b

Store id: 0ec9ccde-ca5a-4105-a0b6-132808d5c4e4

## Text

```text
def _is_pk_set(self, meta=None)
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
- posted_at: `2026-11-09T23:44:48.5300670+00:00`

## Data

```json
{
  "end_line": 723,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 710,
  "symbol": "Model._is_pk_set"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":710,"selector":"L710-L723","symbol":"Model._is_pk_set"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model._is_pk_set](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 723,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 710,
    "symbol": "Model._is_pk_set"
  },
  "id": "0ec9ccde-ca5a-4105-a0b6-132808d5c4e4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.5300670+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 710,
        "selector": "L710-L723",
        "symbol": "Model._is_pk_set"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "84a48eaa-24ea-4c8e-bb87-34bafc763c54",
  "subject_name": "django/db/models/base::Model._is_pk_set",
  "tags": [
    "entity:method"
  ],
  "text": "def _is_pk_set(self, meta=None)"
}
```
