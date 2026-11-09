# Fact b09a980f

Store id: 1fd9bfc6-b950-455e-b415-0f639e91696b

## Text

```text
def as_oracle(self, compiler, connection)
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
- posted_at: `2026-11-09T22:39:43.7269110+00:00`

## Data

```json
{
  "end_line": 605,
  "entity_kind": "method",
  "parent": "KeyTransformIsNull",
  "start_line": 596,
  "symbol": "KeyTransformIsNull.as_oracle"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":596,"selector":"L596-L605","symbol":"KeyTransformIsNull.as_oracle"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::KeyTransformIsNull.as_oracle](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 605,
    "entity_kind": "method",
    "parent": "KeyTransformIsNull",
    "start_line": 596,
    "symbol": "KeyTransformIsNull.as_oracle"
  },
  "id": "1fd9bfc6-b950-455e-b415-0f639e91696b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.7269110+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 596,
        "selector": "L596-L605",
        "symbol": "KeyTransformIsNull.as_oracle"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "d88020aa-0325-4cf5-9cfa-fd5a49b828ed",
  "subject_name": "django/db/models/fields/json::KeyTransformIsNull.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection)"
}
```
