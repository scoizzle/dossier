# Fact b09a980f

Store id: 1eb954a7-6456-497c-adc5-fada0451c05f

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
- posted_at: `2026-11-09T23:44:51.0377510+00:00`

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
  "id": "1eb954a7-6456-497c-adc5-fada0451c05f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.0377510+00:00"
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
  "subject_id": "33b0c30c-3284-467a-94ca-d883cfd8a23d",
  "subject_name": "django/db/models/fields/json::KeyTransformIsNull.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection)"
}
```
